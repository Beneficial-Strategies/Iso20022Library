// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance6Choice
{
    /// <summary>
    /// Opening balance of this page only. This balance must be the intermediary closing balance of the previous page of the same statement.
    /// </summary>
    [IsoId("_AJCXeSp8EeyR9JrVGfaMKw")]
    [DisplayName("Intermediary")]
    public partial record Intermediary : OpeningBalance6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
