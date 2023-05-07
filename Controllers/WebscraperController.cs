using Microsoft.AspNetCore.Mvc;
using BuildComp_Database.Services;
using BuildComp_Database.Models.DTO;

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

    [HttpPost("GetGpuData")]

    public bool GetGpuData(GpuDTO data)
    {
        return _data.AddGpuData(data);
    }

    [HttpPost("GetMotherboardData")]

    public bool GetMotherboardData(MotherboardDTO data)
    {
        return _data.AddMotherboardData(data);
    }

    [HttpPost("GetCaseData")]

    public bool GetCaseData(CaseDTO data)
    {
        return _data.AddCaseData(data);
    }

    [HttpPost("GetRamData")]

    public bool GetRamData(RamDTO data)
    {
        return _data.AddRamData(data);
    }

    [HttpPost("GetPsData")]

    public bool GetPsData(PsDTO data)
    {
        return _data.AddPSData(data);
    }

    [HttpPost("GetHeatsinkData")]

    public bool GetHeatsinkData(HeatsinkDTO data)
    {
        return _data.AddHeatsinkData(data);
    }

    [HttpPost("GetHardDriveData")]

    public bool GetHardDriveData(HardDriveDTO data)
    {
        return _data.AddHardDriveData(data);
    }

}
