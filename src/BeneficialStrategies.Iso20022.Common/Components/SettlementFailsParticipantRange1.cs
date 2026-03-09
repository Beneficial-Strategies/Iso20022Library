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
/// Specifies the details of the participants with the highest volume and value ranking for settlement fails.
/// </summary>
[IsoId("_VEBnQI0UEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Participant Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsParticipantRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Participant with the highest volume of settlement fails.
    /// </summary>
    [IsoId("_acReUI0UEemUAO64Q252gQ")]
    [DisplayName("Highest In Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstInVol")]
    #endif
    [IsoXmlTag("HghstInVol")]
    public ValueList<SettlementFailsParticipant1> HighestInVolume { get; init; } = new ValueList<SettlementFailsParticipant1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _acReUI0UEemUAO64Q252gQ
    
    /// <summary>
    /// Participant with the highest value of settlement fails.
    /// </summary>
    [IsoId("_cDRRUI0UEemUAO64Q252gQ")]
    [DisplayName("Highest In Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstInVal")]
    #endif
    [IsoXmlTag("HghstInVal")]
    public ValueList<SettlementFailsParticipant1> HighestInValue { get; init; } = new ValueList<SettlementFailsParticipant1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _cDRRUI0UEemUAO64Q252gQ
    
    
    #nullable disable
    
}
