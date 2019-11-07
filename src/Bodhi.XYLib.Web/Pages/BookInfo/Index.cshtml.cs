using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Bodhi.XYLib.Web.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Bodhi.XYLib.Web.Pages.BookInfo
{
    public class IndexModel : XYLibPageModel
    {
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = { ".xls",".xlsx" };
        private readonly string _targetFilePath;

        IBookInfoAppService _bookInfoAppService;

        public IndexModel(IConfiguration config, IBookInfoAppService bookInfoAppService)
        {
            _fileSizeLimit = config.GetValue<long>("FileSizeLimit", 100*1000*1000);

            // To save physical files to a path provided by configuration:
            _targetFilePath = config.GetValue<string>("StoredFilesPath", "Uploads");

            _bookInfoAppService = bookInfoAppService;
        }

        [BindProperty]
        public BufferedSingleFileUploadPhysical FileUpload { get; set; }
        public string Result { get; private set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostUploadAsync()
        {
            if (!ModelState.IsValid)
            {
                Result = "Please correct the form.";
                return Page();
            }

            var formFileContent =
                await FileHelpers.ProcessFormFile<BufferedSingleFileUploadPhysical>(
                    FileUpload.FormFile, ModelState, _permittedExtensions,
                    _fileSizeLimit);

            if (!ModelState.IsValid)
            {
                Result = "Please correct the form.";
                return Page();
            }

            Result = _bookInfoAppService.Import(formFileContent);
            return Page();
            //return RedirectToPage("./Index");
        }


    }

    public class BufferedSingleFileUploadPhysical
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }

        [Display(Name = "Note")]
        [StringLength(50, MinimumLength = 0)]
        public string Note { get; set; }
    }
}