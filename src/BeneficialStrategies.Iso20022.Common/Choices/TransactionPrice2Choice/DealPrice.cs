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
namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice2Choice
{
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_Rp1CmNp-Ed-ak6NoX_4Aeg_997208327")]
    [DisplayName("Deal Price")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DealPrice : TransactionPrice2Choice_
    #else
    public partial class DealPrice : TransactionPrice2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DealPrice instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DealPrice( System.String reqCurrency,System.Decimal reqAmount )
        {
            Currency = reqCurrency;
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Currency")]
        [DisplayName("Active Or Historic Currency And Amount _ Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Currency")]
        #endif
        [IsoXmlTag("Currency")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required System.String Currency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Currency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Currency { get; init; } 
        #else
        public System.String Currency { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Amount")]
        [DisplayName("Active Or Historic Currency And Amount _ Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amount")]
        #endif
        [IsoXmlTag("Amount")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required System.Decimal Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal Amount { get; init; } 
        #else
        public System.Decimal Amount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
