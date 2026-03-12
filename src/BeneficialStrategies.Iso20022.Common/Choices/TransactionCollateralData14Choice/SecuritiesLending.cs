// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData14Choice
{
    /// <summary>
    /// Data on collateral used for the securities lending transaction.
    /// </summary>
    [IsoId("_kyCmNf_9Eemefbt-QjTNnA")]
    [DisplayName("Securities Lending")]
    public partial record SecuritiesLending : TransactionCollateralData14Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
