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
[IsoId("_PXWpqtp-Ed-ak6NoX_4Aeg_1436936295")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount20
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_PXgaoNp-Ed-ak6NoX_4Aeg_1615054967")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification10Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PXgaodp-Ed-ak6NoX_4Aeg_1323097229")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification2? AlternateIdentification { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PXgaotp-Ed-ak6NoX_4Aeg_617982614")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    [IsoId("_PXgao9p-Ed-ak6NoX_4Aeg_-2066556561")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; }

    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    [IsoId("_PXgapNp-Ed-ak6NoX_4Aeg_1231338382")]
    [DisplayName("Commission Account")]
    [IsoXmlTag("ComssnAcct")]
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; }

    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_PXgapdp-Ed-ak6NoX_4Aeg_234266029")]
    [DisplayName("Tax Account")]
    [IsoXmlTag("TaxAcct")]
    public CashAccountIdentification5Choice_? TaxAccount { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_PXgaptp-Ed-ak6NoX_4Aeg_-762806324")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation2? AdditionalInformation { get; init; }
}
