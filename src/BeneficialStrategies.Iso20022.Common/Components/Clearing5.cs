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
/// Provides the clearing details.
/// </summary>
[IsoId("_j1HYEZBeEeakHoV5BVecAQ")]
[DisplayName("Clearing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Clearing5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the clearing member identification and account.
    /// </summary>
    [IsoId("_kEl-gZBeEeakHoV5BVecAQ")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    public ValueList<PartyIdentificationAndAccount149> ClearingMember { get; init; } = new ValueList<PartyIdentificationAndAccount149>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _kEl-gZBeEeakHoV5BVecAQ
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_kEl-g5BeEeakHoV5BVecAQ")]
    [DisplayName("Clearing Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSgmt")]
    #endif
    [IsoXmlTag("ClrSgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification127Choice_? ClearingSegment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification127Choice_? ClearingSegment { get; init; } 
    #else
    public PartyIdentification127Choice_? ClearingSegment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
