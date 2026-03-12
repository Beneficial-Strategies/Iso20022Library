// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance1Choice
{
    /// <summary>
    /// Opening balance for the statement period. It always equals the closing balance of the previous statement.
    /// </summary>
    [IsoId("_R9WbiNp-Ed-ak6NoX_4Aeg_-773103442")]
    [DisplayName("First")]
    public partial record First : OpeningBalance1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
