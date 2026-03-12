// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionQuantities2Choice
{
    /// <summary>
    /// Specifies the quantity (such as securities) in the underlying transaction.
    /// </summary>
    [IsoId("_tqJEMlkyEeGeoaLUQk__nA_-160606030")]
    [DisplayName("Quantity")]
    public partial record Quantity : TransactionQuantities2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
