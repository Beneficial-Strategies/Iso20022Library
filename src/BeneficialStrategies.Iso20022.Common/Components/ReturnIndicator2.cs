// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return Indicator2.
/// </summary>
[IsoId("_dG4aQTd4Ee62mtJT34z25w")]
[DisplayName("Return Indicator2")]
public record ReturnIndicator2
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax500Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Authority Request Type.
    /// </summary>
    [DisplayName("Authority Request Type")]
    [IsoXmlTag("AuthrtyReqTp")]
    public required AuthorityRequestType1 AuthorityRequestType { get; init; }

    /// <summary>
    /// Investigation Result.
    /// </summary>
    [DisplayName("Investigation Result")]
    [IsoXmlTag("InvstgtnRslt")]
    public required InvestigationResult1Choice_ InvestigationResult { get; init; }

    /// <summary>
    /// Response Period.
    /// </summary>
    [DisplayName("Response Period")]
    [IsoXmlTag("RspnPrd")]
    public DateOrDateTimePeriod1Choice_? ResponsePeriod { get; init; }
}
