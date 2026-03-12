// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification38Choice
{
    /// <summary>
    /// Unique identification of the cash account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_mmlMg-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Cash Account Identification")]
    public partial record CashAccountIdentification : AccountIdentification38Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
