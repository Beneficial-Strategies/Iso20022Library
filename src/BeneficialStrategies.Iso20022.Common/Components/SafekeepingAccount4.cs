// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// A safekeeping account is an account on which a securities entry is made.
/// </summary>
[IsoId("_QTQRM9p-Ed-ak6NoX_4Aeg_1467329706")]
[DisplayName("Safekeeping Account")]
public record SafekeepingAccount4
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_QTQRNNp-Ed-ak6NoX_4Aeg_1467329736")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_QTQRNdp-Ed-ak6NoX_4Aeg_1467330169")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification9Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_QTQRNtp-Ed-ak6NoX_4Aeg_1467330108")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount2? SubAccountDetails { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QTQRN9p-Ed-ak6NoX_4Aeg_1467329798")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<HoldingBalance5> InstructedBalance { get; init; } = [];

    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_QTQRONp-Ed-ak6NoX_4Aeg_1467330478")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification9Choice_> RightsHolder { get; init; } = [];
}
