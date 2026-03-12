// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus2Choice
{
    /// <summary>
    /// Status of the transfer is failed settlement, that is, settlement in the International Central Securities Depository (ICSD) or Central Securities Depository (CSD) failed.
    /// </summary>
    [IsoId("_aQ-GOyY3EeW_ZNn8gbfY7Q")]
    [DisplayName("Failed Settlement")]
    public partial record FailedSettlement : TransferStatus2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
