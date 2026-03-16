// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Undertaking extend or pay query details.
/// </summary>
[IsoId("_-Des53ltEeG7BsjMvd1mEw_2002292702")]
[DisplayName("Extend Or Pay Query")]
public record ExtendOrPayQuery1
{
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Des6HltEeG7BsjMvd1mEw_-1747808883")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking9 UndertakingIdentification { get; init; }

    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-Dn20HltEeG7BsjMvd1mEw_554766845")]
    [DisplayName("Demand Details")]
    [IsoXmlTag("DmndDtls")]
    public required Demand2 DemandDetails { get; init; }

    /// <summary>
    /// Requested new expiry date as an alternative to payment of the demand.
    /// </summary>
    [IsoId("_-Dn20XltEeG7BsjMvd1mEw_2099672583")]
    [DisplayName("Requested Expiry Date")]
    [IsoXmlTag("ReqdXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExpiryDate { get; init; }

    /// <summary>
    /// Details of the instructions from the bank.
    /// </summary>
    [IsoId("_-Dn20nltEeG7BsjMvd1mEw_1332855114")]
    [DisplayName("Bank Instructions")]
    [IsoXmlTag("BkInstrs")]
    public BankInstructions1? BankInstructions { get; init; }

    /// <summary>
    /// Contact at the issuing bank.
    /// </summary>
    [IsoId("_-Dn203ltEeG7BsjMvd1mEw_916958004")]
    [DisplayName("Bank Contact")]
    [IsoXmlTag("BkCtct")]
    public Contacts3? BankContact { get; init; }

    /// <summary>
    /// Document or template enclosed in the request.
    /// </summary>
    [IsoId("_-Dxn0HltEeG7BsjMvd1mEw_-1682717592")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public Document9? EnclosedFile { get; init; }

    /// <summary>
    /// Additional information related to the request.
    /// </summary>
    [IsoId("_-Dxn0XltEeG7BsjMvd1mEw_1306509943")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
