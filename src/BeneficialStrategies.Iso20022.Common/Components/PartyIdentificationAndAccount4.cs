// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party involved in the settlement chain.
/// </summary>
[IsoId("_PbYOCNp-Ed-ak6NoX_4Aeg_957195353")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount4
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Pbh_ANp-Ed-ak6NoX_4Aeg_957195379")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification2Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_Pbh_Adp-Ed-ak6NoX_4Aeg_957195413")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification1? AccountIdentification { get; init; }

    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    [IsoId("_Pbh_Atp-Ed-ak6NoX_4Aeg_957195438")]
    [DisplayName("Processing Reference")]
    [IsoXmlTag("PrcgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingReference { get; init; }

    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    [IsoId("_Pbh_A9p-Ed-ak6NoX_4Aeg_957195721")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeChoice_? ProcessingDate { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_Pbh_BNp-Ed-ak6NoX_4Aeg_1315522425")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount1? SubAccountDetails { get; init; }

    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("_Pbh_Bdp-Ed-ak6NoX_4Aeg_1047417931")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }
}
