// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification34Choice
{
    /// <summary>
    /// Identification of constituents for a basket of indexes.
    /// </summary>
    [IsoId("_Zlr-pw1HEeqV4s5SpzR1dQ")]
    [DisplayName("Basket Constituents")]
    public record BasketConstituents : SecurityIdentification34Choice_ { }
}
