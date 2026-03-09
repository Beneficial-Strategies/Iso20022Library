// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of entity involved in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pHKm8Q0wEeqUVL7sB4m7NA")]
[Description(@"Identification of the type of entity involved in a transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType33Code
{
    /// <summary>
    /// Point Of Interaction initiating the card payment transaction.
    /// Encoded/decoded by serializers as &quot;OPOI&quot;.
    /// </summary>
    [EnumMember(Value = "OPOI")]
    [IsoId("_pTLpsQ0wEeqUVL7sB4m7NA")]
    [Description(@"Point Of Interaction initiating the card payment transaction.")]
    OriginatingPOI = PartyTypeCode.OriginatingPOI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_pTLpsw0wEeqUVL7sB4m7NA")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_pTLptQ0wEeqUVL7sB4m7NA")]
    [Description(@"Card acceptor, party accepting the card and presenting transaction data to the acquirer.")]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_pTLptw0wEeqUVL7sB4m7NA")]
    [Description(@"Party acting on behalf of other parties to process or forward data to other parties.")]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_pTLpuQ0wEeqUVL7sB4m7NA")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_pTLpuw0wEeqUVL7sB4m7NA")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_pTLpvQ0wEeqUVL7sB4m7NA")]
    [Description(@"Party to whom the card issuer delegates to authorise card payment transactions.")]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Responsible for the maintenance of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as &quot;MTMG&quot;.
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_nABSQQ1GEeqjM-rxn3HuXQ")]
    [Description(@"Responsible for the maintenance of a card payment acceptance terminal.")]
    MasterTerminalManager = PartyTypeCode.MasterTerminalManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax authority.
    /// Encoded/decoded by serializers as &quot;TAXH&quot;.
    /// </summary>
    [EnumMember(Value = "TAXH")]
    [IsoId("_pRciUQ1GEeqjM-rxn3HuXQ")]
    [Description(@"Tax authority.")]
    TaxAuthority = PartyTypeCode.TaxAuthority, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Responsible for one or several maintenance functions of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as &quot;TMGT&quot;.
    /// </summary>
    [EnumMember(Value = "TMGT")]
    [IsoId("_p-q0sA1GEeqjM-rxn3HuXQ")]
    [Description(@"Responsible for one or several maintenance functions of a card payment acceptance terminal.")]
    TerminalManager = PartyTypeCode.TerminalManager, // same ordinal as derivation source for type conversions
    
}
