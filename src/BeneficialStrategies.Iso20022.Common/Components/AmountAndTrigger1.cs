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
/// Amount and trigger information.
/// </summary>
[IsoId("_-GTXZnltEeG7BsjMvd1mEw_-1985688302")]
[DisplayName("Amount And Trigger")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndTrigger1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountAndTrigger1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountAndTrigger1( System.String reqIdentification,AmountOrPercentage1Choice_ reqAmountDetailsChoice )
    {
        Identification = reqIdentification;
        AmountDetailsChoice = reqAmountDetailsChoice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the amount and trigger details.
    /// </summary>
    [IsoId("_-GTXZ3ltEeG7BsjMvd1mEw_-1458509078")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between an amount and a percentage.
    /// </summary>
    [IsoId("_-GTXaHltEeG7BsjMvd1mEw_-1720196234")]
    [DisplayName("Amount Details Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtlsChc")]
    #endif
    [IsoXmlTag("AmtDtlsChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrPercentage1Choice_ AmountDetailsChoice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrPercentage1Choice_ AmountDetailsChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentage1Choice_ AmountDetailsChoice { get; init; } 
    #else
    public AmountOrPercentage1Choice_ AmountDetailsChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Trigger that causes the variation to come into effect.
    /// </summary>
    [IsoId("_-GdIYHltEeG7BsjMvd1mEw_-206552408")]
    [DisplayName("Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trggr")]
    #endif
    [IsoXmlTag("Trggr")]
    public ValueList<Trigger1> Trigger { get; init; } = new ValueList<Trigger1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-GdIYHltEeG7BsjMvd1mEw_-206552408
    
    
    #nullable disable
    
}
