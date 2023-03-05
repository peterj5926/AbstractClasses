using System;
using AbstractClasses.Library;
using AbstractClasses.MediaSelection;
namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IFileService _fileService;
    public MainService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void Invoke()
    {
        MediaSelection selection = new MediaSelection();
        selection.Search();
        
       
    }
}
