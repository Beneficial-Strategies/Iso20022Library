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
/// Amount of money characterics used to specify a limit.
/// </summary>
[IsoId("_jORO5O5NEeCisYr99QEiWA_-1135919214")]
[DisplayName("Limit Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LimitAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LimitAmount1( CreditDebitAmount1 reqAmount,CreditDebitAmount1 reqUtilisationAmount,CreditDebitAmount1 reqAvailableAmount )
    {
        Amount = reqAmount;
        UtilisationAmount = reqUtilisationAmount;
        AvailableAmount = reqAvailableAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_jOa_4O5NEeCisYr99QEiWA_-1878638285")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitAmount1 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitAmount1 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitAmount1 Amount { get; init; } 
    #else
    public CreditDebitAmount1 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Utilised amount of money of the limit expressed in an eligible currency.
    /// </summary>
    [IsoId("_jOa_4e5NEeCisYr99QEiWA_-1682012024")]
    [DisplayName("Utilisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UtlstnAmt")]
    #endif
    [IsoXmlTag("UtlstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitAmount1 UtilisationAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitAmount1 UtilisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitAmount1 UtilisationAmount { get; init; } 
    #else
    public CreditDebitAmount1 UtilisationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining amount of money of the limit expressed in an eligible currency.
    /// </summary>
    [IsoId("_jOa_4u5NEeCisYr99QEiWA_1097770186")]
    [DisplayName("Available Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblAmt")]
    #endif
    [IsoXmlTag("AvlblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitAmount1 AvailableAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitAmount1 AvailableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitAmount1 AvailableAmount { get; init; } 
    #else
    public CreditDebitAmount1 AvailableAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
