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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity22Choice
{
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_N-fhVwU-EeGZxNLgzisRtw")]
    [DisplayName("Face Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FaceAmount : FinancialInstrumentQuantity22Choice_
    #else
    public partial class FaceAmount : FinancialInstrumentQuantity22Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FaceAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FaceAmount( System.String reqCurrency,System.Decimal reqAmount )
        {
            Currency = reqCurrency;
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_XZJV1Np-Ed-ak6NoX_4Aeg_681057429_Currency")]
        [DisplayName("Restricted FIN Implied Currency And Amount _ Currency")]
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
        [IsoId("_XZJV1Np-Ed-ak6NoX_4Aeg_681057429_Amount")]
        [DisplayName("Restricted FIN Implied Currency And Amount _ Amount")]
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
