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
/// Choice of formats to express the type of cash balance.
/// </summary>
[IsoId("_Rl0FQdp-Ed-ak6NoX_4Aeg_-1191454030")]
[DisplayName("Cash Balance Type 1 Format Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalanceType1FormatType
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalanceType1FormatType instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalanceType1FormatType( CashBalanceType1Code reqCode,GenericIdentification13 reqProprietary )
    {
        Code = reqCode;
        Proprietary = reqProprietary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Standard code to specify the type of cash balance.
    /// </summary>
    [IsoId("_Rl0FQtp-Ed-ak6NoX_4Aeg_736479285")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashBalanceType1Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashBalanceType1Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceType1Code Code { get; init; } 
    #else
    public CashBalanceType1Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary code to express the type of cash balance.
    /// </summary>
    [IsoId("_Rl0FQ9p-Ed-ak6NoX_4Aeg_736479254")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification13 Proprietary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification13 Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification13 Proprietary { get; init; } 
    #else
    public GenericIdentification13 Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
