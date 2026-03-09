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
/// Information about a Money Purchase Annual Allowance (MPAA).
/// </summary>
[IsoId("_YYAkcFK7EeiSDqv62fL07g")]
[DisplayName("Money Purchase Annual Allowance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MoneyPurchaseAnnualAllowance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MoneyPurchaseAnnualAllowance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MoneyPurchaseAnnualAllowance1( System.String reqTriggered )
    {
        Triggered = reqTriggered;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the annual allowance has been triggered.
    /// </summary>
    [IsoId("_havwQFK7EeiSDqv62fL07g")]
    [DisplayName("Triggered")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trggrd")]
    #endif
    [IsoXmlTag("Trggrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Triggered { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Triggered { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Triggered { get; init; } 
    #else
    public System.String Triggered { get; set; } 
    #endif
    
    /// <summary>
    /// Date the annual allowance is taken.
    /// </summary>
    [IsoId("_kmRREFK7EeiSDqv62fL07g")]
    [DisplayName("Triggered Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrggrdDt")]
    #endif
    [IsoXmlTag("TrggrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TriggeredDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TriggeredDate { get; init; } 
    #else
    public System.DateOnly? TriggeredDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
