// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment2"/>
[IsoId("_tlOvAVkyEeGeoaLUQk__nA_-1635096845")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment2
{
    /// <inheritdoc cref="IMandateAmendment2.OriginalMessageInformation"/>
    [IsoId("_tlOvAlkyEeGeoaLUQk__nA_1370840360")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment2.AmendmentReason"/>
    [IsoId("_tlOvA1kyEeGeoaLUQk__nA_675034051")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason1 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment2.Mandate"/>
    [IsoId("_tlX48FkyEeGeoaLUQk__nA_454715992")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate3 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment2.OriginalMandate"/>
    [IsoId("_tlX48VkyEeGeoaLUQk__nA_1435976193")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; }
}
