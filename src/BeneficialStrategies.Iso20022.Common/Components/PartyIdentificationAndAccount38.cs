// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_K2BzWeaOEd-q8fx_Zl_34A")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount38
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_K2BzW-aOEd-q8fx_Zl_34A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification49Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_K2BzXeaOEd-q8fx_Zl_34A")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification2? AlternateIdentification { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_K2BzX-aOEd-q8fx_Zl_34A")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    [IsoId("_K2BzYeaOEd-q8fx_Zl_34A")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; }

    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    [IsoId("_K2BzY-aOEd-q8fx_Zl_34A")]
    [DisplayName("Commission Account")]
    [IsoXmlTag("ComssnAcct")]
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; }

    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_K2BzZeaOEd-q8fx_Zl_34A")]
    [DisplayName("Tax Account")]
    [IsoXmlTag("TaxAcct")]
    public CashAccountIdentification5Choice_? TaxAccount { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_K2BzZ-aOEd-q8fx_Zl_34A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation2? AdditionalInformation { get; init; }
}
