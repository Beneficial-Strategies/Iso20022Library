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
/// Information about an amount.
/// </summary>
[IsoId("_95C-gXltEeG7BsjMvd1mEw_-215420241")]
[DisplayName("Undertaking Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAmount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAmount2( Amount1Choice_ reqAmountChoice )
    {
        AmountChoice = reqAmountChoice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice of amounts.
    /// </summary>
    [IsoId("_95C-gnltEeG7BsjMvd1mEw_973191229")]
    [DisplayName("Amount Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtChc")]
    #endif
    [IsoXmlTag("AmtChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount1Choice_ AmountChoice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount1Choice_ AmountChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount1Choice_ AmountChoice { get; init; } 
    #else
    public Amount1Choice_ AmountChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information concerning the amended amount.
    /// </summary>
    [IsoId("_95C-g3ltEeG7BsjMvd1mEw_-1235765635")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
