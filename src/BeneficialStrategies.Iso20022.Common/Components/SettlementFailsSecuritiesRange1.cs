// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the highest volume and value of settlement fails with a ranking by financial instrument.
/// </summary>
[IsoId("_BnlYg40bEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Securities Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsSecuritiesRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Securities with the highest volume of settlement fails.
    /// </summary>
    [IsoId("_BnlYhY0bEemUAO64Q252gQ")]
    [DisplayName("Highest In Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstInVol")]
    #endif
    [IsoXmlTag("HghstInVol")]
    public ValueList<SettlementFailsSecurities1> HighestInVolume { get; init; } = new ValueList<SettlementFailsSecurities1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _BnlYhY0bEemUAO64Q252gQ
    
    /// <summary>
    /// Securities with the highest value of settlement fails.
    /// </summary>
    [IsoId("_BnlYhI0bEemUAO64Q252gQ")]
    [DisplayName("Highest In Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstInVal")]
    #endif
    [IsoXmlTag("HghstInVal")]
    public ValueList<SettlementFailsSecurities1> HighestInValue { get; init; } = new ValueList<SettlementFailsSecurities1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _BnlYhI0bEemUAO64Q252gQ
    
    
    #nullable disable
    
}
