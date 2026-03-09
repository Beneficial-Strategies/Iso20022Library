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
/// Describes the time-out consequences.
/// </summary>
[IsoId("_Utx7w9p-Ed-ak6NoX_4Aeg_263935845")]
[DisplayName("Time Out Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TimeOutResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TimeOutResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TimeOutResult1( TransactionStatus2 reqTransactionFutureStatus )
    {
        TransactionFutureStatus = reqTransactionFutureStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the transaction if no action is taken by the user.
    /// </summary>
    [IsoId("_Utx7xNp-Ed-ak6NoX_4Aeg_1691671340")]
    [DisplayName("Transaction Future Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxFutrSts")]
    #endif
    [IsoXmlTag("TxFutrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus2 TransactionFutureStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus2 TransactionFutureStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus2 TransactionFutureStatus { get; init; } 
    #else
    public TransactionStatus2 TransactionFutureStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the time-out reason.
    /// </summary>
    [IsoId("_Utx7xdp-Ed-ak6NoX_4Aeg_653870877")]
    [DisplayName("Time Out Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmOutEvt")]
    #endif
    [IsoXmlTag("TmOutEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeOutEvent1? TimeOutEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeOutEvent1? TimeOutEvent { get; init; } 
    #else
    public TimeOutEvent1? TimeOutEvent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
