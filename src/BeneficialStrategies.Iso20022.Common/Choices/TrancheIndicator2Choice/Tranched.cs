// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TrancheIndicator2Choice
{
    /// <summary>
    /// Indication that derivative contract is tranched.
    /// </summary>
    [IsoId("_52td0byOEeaUov4jN5X9Qw")]
    [DisplayName("Tranched")]
    public record Tranched : TrancheIndicator2Choice_
    {
        /// <summary>
        /// Indicates the point at which losses in the pool will attach to a particular tranche.
        /// </summary>
        [IsoId("_OpEH4byOEeaUov4jN5X9Qw")]
        [DisplayName("Attachment Point")]
        [IsoXmlTag("AttchmntPt")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public IsoBaseOneRate? AttachmentPoint { get; init; }

        /// <summary>
        /// Indicates the point beyond which losses do not affect the particular tranche.
        /// </summary>
        [IsoId("_OpEH47yOEeaUov4jN5X9Qw")]
        [DisplayName("Detachment Point")]
        [IsoXmlTag("DtchmntPt")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public IsoBaseOneRate? DetachmentPoint { get; init; }
    }
}
