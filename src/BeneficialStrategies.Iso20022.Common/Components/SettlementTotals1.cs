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
/// Settlement totals or the report.
/// </summary>
[IsoId("_jWGXwFdGEeeIAMBcVOw01w")]
[DisplayName("Settlement Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementTotals1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Settlement totals for the acquirer.
    /// </summary>
    [IsoId("_ukPEIFdGEeeIAMBcVOw01w")]
    [DisplayName("Acquirer Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrTtls")]
    #endif
    [IsoXmlTag("AcqrrTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal1? AcquirerTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal1? AcquirerTotals { get; init; } 
    #else
    public SettlementCategoryTotal1? AcquirerTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement totals for the issuer.
    /// </summary>
    [IsoId("_28ZB4FdGEeeIAMBcVOw01w")]
    [DisplayName("Issuer Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrTtls")]
    #endif
    [IsoXmlTag("IssrTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal1? IssuerTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal1? IssuerTotals { get; init; } 
    #else
    public SettlementCategoryTotal1? IssuerTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Other settlement totals.
    /// </summary>
    [IsoId("_8iNa4FdGEeeIAMBcVOw01w")]
    [DisplayName("Other Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTtls")]
    #endif
    [IsoXmlTag("OthrTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal1? OtherTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal1? OtherTotals { get; init; } 
    #else
    public SettlementCategoryTotal1? OtherTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount settled.
    /// </summary>
    [IsoId("_2zMkYNvyEeeOusYHZbyj7w")]
    [DisplayName("Total Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSttlmAmt")]
    #endif
    [IsoXmlTag("TtlSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal1? TotalSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal1? TotalSettlementAmount { get; init; } 
    #else
    public SettlementCategoryTotal1? TotalSettlementAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
