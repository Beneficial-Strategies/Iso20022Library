// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus3Choice
{
    /// <summary>
    /// Status of the transfer is failed settlement, that is, settlement in the International Central Securities Depository (ICSD) or Central Securities Depository (CSD) failed.
    /// </summary>
    [IsoId("_aeWNW1NUEeijdq8ilaxyOA")]
    [DisplayName("Failed Settlement")]
    public partial record FailedSettlement : TransferStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
