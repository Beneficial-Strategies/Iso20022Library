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
/// Trigger parameters.
/// </summary>
[IsoId("_99Ns1nltEeG7BsjMvd1mEw_340413416")]
[DisplayName("Trigger")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Trigger1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the date on which a variation is effective.
    /// </summary>
    [IsoId("_99Ns13ltEeG7BsjMvd1mEw_-1029546391")]
    [DisplayName("Date Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtChc")]
    #endif
    [IsoXmlTag("DtChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FixedOrRecurrentDate1Choice_? DateChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FixedOrRecurrentDate1Choice_? DateChoice { get; init; } 
    #else
    public FixedOrRecurrentDate1Choice_? DateChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the documentary event on which a variation is triggered.
    /// </summary>
    [IsoId("_99Ns2HltEeG7BsjMvd1mEw_-1230694624")]
    [DisplayName("Documentary Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcmntryEvt")]
    #endif
    [IsoXmlTag("DcmntryEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document10? DocumentaryEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document10? DocumentaryEvent { get; init; } 
    #else
    public Document10? DocumentaryEvent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
