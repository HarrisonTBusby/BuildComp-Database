using Microsoft.AspNetCore.Mvc;
using BuildComp_Database.Services;
using BuildComp_Database.Models.DTO;
using BuildComp_Database.Models;

namespace BuildComp_Database.Controllers;

[ApiController]
[Route("[controller]")]
public class WebscraperController : ControllerBase
{

    private readonly WebscraperService _data;
    public WebscraperController(WebscraperService dataFromService)
    {
        _data = dataFromService;
    }

    [HttpPost("GetCpuData")]

    public bool GetCpuData(CpuDTO data)
    {
        return _data.AddCpuData(data);
    }

    [HttpGet]
    [Route("GetAllCpuData")]
    public IEnumerable<CPUModel> GetAllCpuData(){
        return _data.GetAllCpuData();
    }

    [HttpPost("GetGpuData")]

    public bool GetGpuData(GpuDTO data)
    {
        return _data.AddGpuData(data);
    }

    [HttpGet]
    [Route("GetAllGpuData")]
    public IEnumerable<GPUModel> GetAllGpuData(){
        return _data.GetAllGpuData();
    }

    [HttpPost("GetMotherboardData")]

    public bool GetMotherboardData(MotherboardDTO data)
    {
        return _data.AddMotherboardData(data);
    }

    [HttpGet]
    [Route("GetAllMotherboardData")]
    public IEnumerable<MotherboardModel> GetAllMotherboardData(){
        return _data.GetAllMotherboardData();
    }


    [HttpPost("GetCaseData")]

    public bool GetCaseData(CaseDTO data)
    {
        return _data.AddCaseData(data);
    }

    [HttpGet]
    [Route("GetAllCaseData")]
    public IEnumerable<CaseModel> GetAllCaseData(){
        return _data.GetAllCaseData();
    }

    [HttpPost("GetRamData")]

    public bool GetRamData(RamDTO data)
    {
        return _data.AddRamData(data);
    }

    [HttpGet]
    [Route("GetAllRamData")]
    public IEnumerable<RamModel> GetAllRamData(){
        return _data.GetAllRamData();
    }

    [HttpPost("GetPsData")]

    public bool GetPsData(PsDTO data)
    {
        return _data.AddPSData(data);
    }

    [HttpGet]
    [Route("GetAllPsData")]
    public IEnumerable<PsModel> GetAllPsData(){
        return _data.GetAllPsData();
    }

    [HttpPost("GetHeatsinkData")]

    public bool GetHeatsinkData(HeatsinkDTO data)
    {
        return _data.AddHeatsinkData(data);
    }

    [HttpGet]
    [Route("GetAllHeatsinkData")]
    public IEnumerable<HeatsinkModel> GetAllHeatsinkData(){
        return _data.GetAllHeatsinkData();
    }

    [HttpPost("GetHardDriveData")]

    public bool GetHardDriveData(HardDriveDTO data)
    {
        return _data.AddHardDriveData(data);
    }

    [HttpGet]
    [Route("GetAllHardDriveData")]
    public IEnumerable<HardDriveModel> GetAllHardDriveData(){
        return _data.GetAllHardDriveData();
    }

    [HttpPost("saveItemByUsername")]
    public bool saveItemByUsername(WishlistItemDTO data)
    {
        return _data.addWishlistItem(data);
    }

    [HttpGet("GetAllWishlistItems")]

    public IEnumerable<WishlistItemModel> GetAllWishlistItems(){
        return _data.GetAllWishlistItems();
    }

    [HttpDelete("DeleteWishlistItems/{Username}/{Title}")]
    public bool DeleteWishlistItems(string Username, string Title){
        return _data.DeleteWishlistItems(Username, Title);
    }

}
