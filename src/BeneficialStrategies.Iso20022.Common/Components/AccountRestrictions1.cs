// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restrictions that may be applied to an account or investment plan.
/// </summary>
[IsoId("_F1IoQCFiEeW9XJWqfgXIIA")]
[DisplayName("Account Restrictions")]
public record AccountRestrictions1
{
    /// <summary>
    /// Restrictions and/or limitations on the account or account party.
    /// </summary>
    [IsoId("_OkFVYCFiEeW9XJWqfgXIIA")]
    [DisplayName("Limitation")]
    [IsoXmlTag("Lmttn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Limitation { get; init; }

    /// <summary>
    /// Additional information.
    /// </summary>
    [IsoId("_VAAP8CFiEeW9XJWqfgXIIA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Information or instructions for the by-passing of validations in the account registration process.
    /// </summary>
    [IsoId("_ZUWaACFiEeW9XJWqfgXIIA")]
    [DisplayName("Account Validation")]
    [IsoXmlTag("AcctVldtn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AccountValidation { get; init; }

    /// <summary>
    /// Type or identification of the restriction.
    /// </summary>
    [IsoId("_cQ4ckCFiEeW9XJWqfgXIIA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Regulator that may have to be informed about restrictions or limitations on the account or account party.
    /// </summary>
    [IsoId("_d1dNsCFiEeW9XJWqfgXIIA")]
    [DisplayName("Regulator")]
    [IsoXmlTag("Rgltr")]
    public PartyIdentification70Choice_? Regulator { get; init; }

    /// <summary>
    /// Status of the restriction.
    /// </summary>
    [IsoId("_eyT3gCFiEeW9XJWqfgXIIA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public RestrictionStatus1Choice_? Status { get; init; }

    /// <summary>
    /// Period of the restriction.
    /// </summary>
    [IsoId("_foKhcCFiEeW9XJWqfgXIIA")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public DateTimePeriodDetails1? Period { get; init; }
}
