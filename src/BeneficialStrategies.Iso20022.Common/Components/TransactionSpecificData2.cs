// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum data structure applicable to certain merchant verticals that require industry-specific data within transaction messages.
/// </summary>
[IsoId("_v8xEwUYYEfCQAqQ9lolFUg")]
[DisplayName("Transaction Specific Data2")]
public record TransactionSpecificData2
{
    /// <summary>
    /// Contain issuer's purchase restriction applied at POS.
    /// </summary>
    [IsoId("_kSLg8FBgEfC5WMyGsBx7PA")]
    [DisplayName("Purchase Restriction")]
    [IsoXmlTag("PurchsRstrctn")]
    public IsoMax16HexBinaryText? PurchaseRestriction { get; init; }

    /// <summary>
    /// It is designed to carry detail level fleet data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to fleet transactions.
    /// </summary>
    [IsoId("_v_MGoUYYEfCQAqQ9lolFUg")]
    [DisplayName("Fleet Line Item")]
    [IsoXmlTag("FleetLineItm")]
    public ValueList<FleetLineItem6> FleetLineItem { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_zxWwskYYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_zxWws0YYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
