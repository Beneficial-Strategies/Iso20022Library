// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.LimitOrError4Choice
{
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_RixMQXhdEeidzqjNEfehPg")]
    [DisplayName("Limit")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Limit : LimitOrError4Choice_
    #else
    public partial class Limit : LimitOrError4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Limit instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Limit( Amount2Choice_ reqAmount )
        {
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Amount of money of the limit, expressed in an eligible currency.
        /// </summary>
        [IsoId("_Rt38AZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Amount2Choice_ Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Amount2Choice_ Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Amount2Choice_ Amount { get; init; } 
        #else
        public Amount2Choice_ Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies if a limit is a debit limit or a credit limit.
        /// </summary>
        [IsoId("_Rt38A5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Credit Debit Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtDbtInd")]
        #endif
        [IsoXmlTag("CdtDbtInd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        #else
        public CreditDebitCode? CreditDebitIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Status of the limit, such as enabled or disabled.
        /// </summary>
        [IsoId("_Rt38BZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sts")]
        #endif
        [IsoXmlTag("Sts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LimitStatus1Code? Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LimitStatus1Code? Status { get; init; } 
        #else
        public LimitStatus1Code? Status { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the limit becomes effective.
        /// </summary>
        [IsoId("_Rt38B5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Start Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StartDtTm")]
        #endif
        [IsoXmlTag("StartDtTm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTime2Choice_? StartDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTime2Choice_? StartDateTime { get; init; } 
        #else
        public DateAndDateTime2Choice_? StartDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Actual usage of the limit expressed as an amount.
        /// </summary>
        [IsoId("_Rt38CZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Used Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UsdAmt")]
        #endif
        [IsoXmlTag("UsdAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Amount2Choice_? UsedAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Amount2Choice_? UsedAmount { get; init; } 
        #else
        public Amount2Choice_? UsedAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies if the used amount of the limit is a debit amount or a credit amount.
        /// </summary>
        [IsoId("_Rt38C5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Used Amount Credit Debit Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UsdAmtCdtDbtInd")]
        #endif
        [IsoXmlTag("UsdAmtCdtDbtInd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CreditDebitCode? UsedAmountCreditDebitIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CreditDebitCode? UsedAmountCreditDebitIndicator { get; init; } 
        #else
        public CreditDebitCode? UsedAmountCreditDebitIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Actual usage of the limit expressed as a percentage.
        /// </summary>
        [IsoId("_Rt38DZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Used Percentage")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UsdPctg")]
        #endif
        [IsoXmlTag("UsdPctg")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPercentageRate? UsedPercentage { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? UsedPercentage { get; init; } 
        #else
        public System.Decimal? UsedPercentage { get; set; } 
        #endif
        
        /// <summary>
        /// Actual usage of the limit expressed as an amount.
        /// </summary>
        [IsoId("_Rt38D5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Remaining Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RmngAmt")]
        #endif
        [IsoXmlTag("RmngAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Amount2Choice_? RemainingAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Amount2Choice_? RemainingAmount { get; init; } 
        #else
        public Amount2Choice_? RemainingAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
