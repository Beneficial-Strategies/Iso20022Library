// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information about the CA event.
/// </summary>
[IsoId("_UMZtAdp-Ed-ak6NoX_4Aeg_325732462")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative2
{
    /// <summary>
    /// Provides conditional information related to the event, eg, an offer is subject to 50% acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_UMZtAtp-Ed-ak6NoX_4Aeg_339584321")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InformationConditions { get; init; }

    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, eg, not open to US/Canadian residents, QIB or SIL to be provided.
    /// </summary>
    [IsoId("_UMZtA9p-Ed-ak6NoX_4Aeg_339584413")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InformationToComplyWith { get; init; }

    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the SLA.
    /// </summary>
    [IsoId("_UMZtBNp-Ed-ak6NoX_4Aeg_339584383")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? TaxationConditions { get; init; }

    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, eg, beneficial ownership.
    /// </summary>
    [IsoId("_UMZtBdp-Ed-ak6NoX_4Aeg_351590771")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? DeclarationDetails { get; init; }

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_UMZtBtp-Ed-ak6NoX_4Aeg_722848075")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? RegistrationDetails { get; init; }

    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message.
    /// </summary>
    [IsoId("_UMZtB9p-Ed-ak6NoX_4Aeg_339584299")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalText { get; init; }
}
