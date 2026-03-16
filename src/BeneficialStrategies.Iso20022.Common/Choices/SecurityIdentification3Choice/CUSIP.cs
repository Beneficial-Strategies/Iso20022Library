// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. The CUSIP is composed of a 9-character number that uniquely identifies a particular security. Non-US securities have a similar number called the CINS number.
    /// </summary>
    [IsoId("_Qdr_ktp-Ed-ak6NoX_4Aeg_-1393682718")]
    [DisplayName("CUSIP")]
    public record CUSIP : SecurityIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. Non-US securities have a similar number called the CINS number.
        /// </summary>
        [IsoXmlTag("CUSIP")]
        [IsoSimpleType(IsoSimpleType.CUSIPIdentifier)]
        public required IsoCUSIPIdentifier Value { get; init; }
    }
}
