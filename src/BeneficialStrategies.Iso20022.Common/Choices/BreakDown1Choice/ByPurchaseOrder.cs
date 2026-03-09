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
namespace BeneficialStrategies.Iso20022.Choices.BreakDown1Choice
{
    /// <summary>
    /// The intention to pay is based on a purchase order.
    /// </summary>
    [IsoId("_2goZwBrYEeOVR9VN6fAMUg")]
    [DisplayName("By Purchase Order")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ByPurchaseOrder : BreakDown1Choice_
    #else
    public partial class ByPurchaseOrder : BreakDown1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ByPurchaseOrder instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ByPurchaseOrder( DocumentIdentification7 reqPurchaseOrderReference,CurrencyAndAmount reqNetAmount )
        {
            PurchaseOrderReference = reqPurchaseOrderReference;
            NetAmount = reqNetAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification of the purchase order, assigned by the buyer.
        /// </summary>
        [IsoId("_982JIRrXEeOVR9VN6fAMUg")]
        [DisplayName("Purchase Order Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PurchsOrdrRef")]
        #endif
        [IsoXmlTag("PurchsOrdrRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentIdentification7 PurchaseOrderReference { get; init; } 
        #else
        public DocumentIdentification7 PurchaseOrderReference { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the adjustments applied to obtain the net amount.
        /// </summary>
        [IsoId("_982JIxrXEeOVR9VN6fAMUg")]
        [DisplayName("Adjustment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Adjstmnt")]
        #endif
        [IsoXmlTag("Adjstmnt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Adjustment6? Adjustment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Adjustment6? Adjustment { get; init; } 
        #else
        public Adjustment6? Adjustment { get; set; } 
        #endif
        
        /// <summary>
        /// Net amount, after adjustments, intended to be paid.
        /// </summary>
        [IsoId("_982JJRrXEeOVR9VN6fAMUg")]
        [DisplayName("Net Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NetAmt")]
        #endif
        [IsoXmlTag("NetAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CurrencyAndAmount NetAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CurrencyAndAmount NetAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CurrencyAndAmount NetAmount { get; init; } 
        #else
        public CurrencyAndAmount NetAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
