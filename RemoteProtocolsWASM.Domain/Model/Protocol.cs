using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Domain.Model
{
    public class Protocol
    {
        public int ProtocolId { get; set; }
        public string ProtocolNumber { get; set; }
        public int ContractorId { get; set; }
        public string Contractor { get; set; }
        public string ProjectNumber { get; set; }
        public string LocationCode { get; set; }
        public string Location { get; set; }
        public string LocationAddress { get; set; }
        public string TechnicianId { get; set; }
        public int CarId { get; set; }
        public DateTime? ProtocolDate { get; set; }
        public string NotificationDate { get; set; }
        public string FaultTopic { get; set; }
        public string FaulDescription { get; set; }
        public string FaultRepair { get; set; }
        public string HardwareName { get; set; }
        public string ConfirmingPerson { get; set; }
        public DateTime? PreparationTimeStart { get; set; }
        public DateTime? PreparationTimeStop { get; set; }
        public DateTime? TravelTimeStart { get; set; }
        public DateTime? TravelTimeStop { get; set; }
        public DateTime? WorkTimeStart { get; set; }
        public DateTime? WorkTimeStop { get; set; }
        public DateTime? ReturnTimeStart { get; set; }
        public DateTime? ReturnTimeStop { get; set; }
        public int EventId { get; set; }
        public string OnGroupCode { get; set; }
        public bool Kilometers { get; set; }
        public int KilometersTravel { get; set; }
        public int KilometersReturn { get; set; }
        public string Comments { get; set; }
        public string InvoiceType { get; set; }
        public int ProtocolStatus { get; set; }
        public string ManagerId { get; set; }
        public string AccountingSpecialistId { get; set; }
        public string ProtocolSignature { get; set; }
        public int ParentProtocol { get; set; }
        public bool IsServiceDeskProtocol { get; set; }
        public bool IsRepairProtocol { get; set; }
        public string Warehouse { get; set; }
        public string Notes { get; set; }
        public virtual User UserTechnician { get; set; }
        public virtual User UserManager { get; set; }
        public virtual User UserAccouting { get; set; }
        public virtual Car Car { get; set; }
        public virtual Event Event { get; set; }
        public ICollection<ProtocolsAssembly> ProtocolsAssemblies { get; set; }
        public ICollection<ProtocolsDisassembly> ProtocolsDisassemblies { get; set; }
        public virtual Protocol ParrentsProtocol { get; set; }
        public virtual ICollection<Protocol> ParrentsProtocolCollection { get; set; }
    }
}
