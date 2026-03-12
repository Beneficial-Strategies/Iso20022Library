// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IssuerOrInvestor1Choice
{
    /// <summary>
    /// CSD Issuer of a security.
    /// </summary>
    [IsoId("_hh_UomliEeGaMcKyqKNRfQ_851578726")]
    [DisplayName("Issuer CSD")]
    public partial record IssuerCSD : IssuerOrInvestor1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
