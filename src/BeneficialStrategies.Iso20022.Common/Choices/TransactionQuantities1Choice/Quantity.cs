// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionQuantities1Choice
{
    /// <summary>
    /// Specifies the quantity (eg of securities) in the underlying transaction.
    /// </summary>
    [IsoId("_RU0b59p-Ed-ak6NoX_4Aeg_833216676")]
    [DisplayName("Quantity")]
    public partial record Quantity : TransactionQuantities1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
