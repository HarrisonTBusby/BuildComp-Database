using BuildComp_Database.Services.Context;
using Microsoft.AspNetCore.Mvc;
using BuildComp_Database.Models.DTO;
using BuildComp_Database.Models;

namespace BuildComp_Database.Services
{
    public class WebscraperService : ControllerBase
    {
        private readonly DataContext _context;
        public WebscraperService(DataContext context)
        {
            _context = context;
        }
        public bool AddCpuData(CpuDTO CpuInfo)
        {
            CPUModel CPU = new CPUModel();

            CPU.id = CpuInfo.id;
            CPU.title = CpuInfo.title;
            CPU.price = CpuInfo.price;
            CPU.image_url = CpuInfo.image_url;
            CPU.item_url = CpuInfo.item_url;
            CPU.type = CpuInfo.type;
            CPU.socketType = CpuInfo.socketType;
            CPU.cores = CpuInfo.cores;
            CPU.perfCoreClock = CpuInfo.perfCoreClock;

            _context.Add(CPU);



            return _context.SaveChanges() != 0;
        }

        public IEnumerable<CPUModel> GetAllCpuData(){
            return _context.CpuInfo;
        }

        public bool AddGpuData(GpuDTO GpuInfo)
        {
            GPUModel GPU = new GPUModel();

            GPU.id = GpuInfo.id;
            GPU.title = GpuInfo.title;
            GPU.price = GpuInfo.price;
            GPU.image_url = GpuInfo.image_url;
            GPU.item_url = GpuInfo.item_url;
            GPU.type = GpuInfo.type;
            GPU.socketType = GpuInfo.socketType;
            GPU.memory = GpuInfo.memory;
            GPU.perfCoreClock = GpuInfo.perfCoreClock;
            GPU.chipset = GpuInfo.chipset;
            _context.Add(GPU);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<GPUModel> GetAllGpuData(){
            return _context.GpuInfo;
        }

        public bool AddMotherboardData(MotherboardDTO MotherboardInfo)
        {
            MotherboardModel Motherboard = new MotherboardModel();

            Motherboard.id = MotherboardInfo.id;
            Motherboard.title = MotherboardInfo.title;
            Motherboard.price = MotherboardInfo.price;
            Motherboard.image_url = MotherboardInfo.image_url;
            Motherboard.item_url = MotherboardInfo.item_url;
            Motherboard.type = MotherboardInfo.type;
            Motherboard.socketType = MotherboardInfo.socketType;
            Motherboard.gpuPort = MotherboardInfo.gpuPort;
            Motherboard.ramType = MotherboardInfo.ramType;
            Motherboard.ramMax = MotherboardInfo.ramMax;
            Motherboard.memorySlots = MotherboardInfo.memorySlots;
            Motherboard.chipset = MotherboardInfo.chipset;
            Motherboard.PCIESlotNumber = MotherboardInfo.PCIESlotNumber;
            _context.Add(Motherboard);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<MotherboardModel> GetAllMotherboardData(){
            return _context.MotherboardInfo;
        }

        public bool AddCaseData(CaseDTO CaseInfo)
        {
            CaseModel Case = new CaseModel();

            Case.id = CaseInfo.id;
            Case.title = CaseInfo.title;
            Case.price = CaseInfo.price;
            Case.image_url = CaseInfo.image_url;
            Case.item_url = CaseInfo.item_url;
            Case.type = CaseInfo.type;
            Case.size = CaseInfo.size;
            Case.caseColor = CaseInfo.caseColor;

            _context.Add(Case);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<CaseModel> GetAllCaseData(){
            return _context.CaseInfo;
        }

        public bool AddRamData(RamDTO RamInfo)
        {
            RamModel RAM = new RamModel();

            RAM.id = RamInfo.id;
            RAM.title = RamInfo.title;
            RAM.price = RamInfo.price;
            RAM.image_url = RamInfo.image_url;
            RAM.item_url = RamInfo.item_url;
            RAM.type = RamInfo.type;
            RAM.color = RamInfo.color;
            RAM.ramType = RamInfo.ramType;
            RAM.ramSpeed = RamInfo.ramSpeed;
            RAM.moduleAmount = RamInfo.moduleAmount;
            RAM.firstWordLatency = RamInfo.firstWordLatency;

            _context.Add(RAM);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<RamModel> GetAllRamData(){
            return _context.RamInfo;
        }

        public bool AddPSData(PsDTO PsInfo)
        {
            PsModel PowerSupply = new PsModel();

            PowerSupply.id = PsInfo.id;
            PowerSupply.title = PsInfo.title;
            PowerSupply.price = PsInfo.price;
            PowerSupply.image_url = PsInfo.image_url;
            PowerSupply.item_url = PsInfo.item_url;
            PowerSupply.type = PsInfo.type;
            PowerSupply.wattage = PsInfo.wattage;
            PowerSupply.color = PsInfo.color;
            PowerSupply.EPS8ConnectorNum = PsInfo.EPS8ConnectorNum;
            PowerSupply.PCIe62ConnectorNum = PsInfo.PCIe62ConnectorNum;
            PowerSupply.PCIe6ConnectorNum = PsInfo.PCIe6ConnectorNum;
            PowerSupply.SataConnectors = PsInfo.SataConnectors;
            PowerSupply.Molex4ConnectorNum = PsInfo.Molex4ConnectorNum;

            _context.Add(PowerSupply);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<PsModel> GetAllPsData(){
            return _context.PsInfo;
        }


        public bool AddHeatsinkData(HeatsinkDTO HeatsinkInfo)
        {
            HeatsinkModel Heatsink = new HeatsinkModel();

            Heatsink.id = HeatsinkInfo.id;
            Heatsink.title = HeatsinkInfo.title;
            Heatsink.price = HeatsinkInfo.price;
            Heatsink.image_url = HeatsinkInfo.image_url;
            Heatsink.item_url = HeatsinkInfo.item_url;
            Heatsink.type = HeatsinkInfo.type;
            Heatsink.color = HeatsinkInfo.color;
            Heatsink.fanRPM = HeatsinkInfo.fanRPM;
            Heatsink.fanNoise = HeatsinkInfo.fanNoise;
            Heatsink.isWaterCooled = HeatsinkInfo.isWaterCooled;
            

            _context.Add(Heatsink);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<HeatsinkModel> GetAllHeatsinkData(){
            return _context.HeatsinkInfo;
        }

         public bool AddHardDriveData(HardDriveDTO HardDriveInfo)
        {
            HardDriveModel HardDrive = new HardDriveModel();

            HardDrive.id = HardDriveInfo.id;
            HardDrive.title = HardDriveInfo.title;
            HardDrive.price = HardDriveInfo.price;
            HardDrive.image_url = HardDriveInfo.image_url;
            HardDrive.item_url = HardDriveInfo.item_url;
            HardDrive.type = HardDriveInfo.type;
            HardDrive.storageCapacity = HardDriveInfo.storageCapacity;
            HardDrive.PCIeType = HardDriveInfo.PCIeType;
           
            

            _context.Add(HardDrive);

            return _context.SaveChanges() != 0;
        }

        public IEnumerable<HardDriveModel> GetAllHardDriveData(){
            return _context.HardDriveInfo;
        }


    }
}