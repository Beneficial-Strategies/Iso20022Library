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
    /// The intention to pay is based on a commercial invoice.
    /// </summary>
    [IsoId("_6n8NYBrYEeOVR9VN6fAMUg")]
    [DisplayName("By Commercial Invoice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ByCommercialInvoice : BreakDown1Choice_
    #else
    public partial class ByCommercialInvoice : BreakDown1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ByCommercialInvoice instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ByCommercialInvoice( InvoiceIdentification1 reqCommercialDocumentReference,CurrencyAndAmount reqNetAmount )
        {
            CommercialDocumentReference = reqCommercialDocumentReference;
            NetAmount = reqNetAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference to the identification of the underlying commercial document.
        /// </summary>
        [IsoId("_Ti7gwRrYEeOVR9VN6fAMUg")]
        [DisplayName("Commercial Document Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ComrclDocRef")]
        #endif
        [IsoXmlTag("ComrclDocRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvoiceIdentification1 CommercialDocumentReference { get; init; } 
        #else
        public InvoiceIdentification1 CommercialDocumentReference { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the adjustments applied to obtain the net amount.
        /// </summary>
        [IsoId("_Ti7gwxrYEeOVR9VN6fAMUg")]
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
        [IsoId("_Ti7gxRrYEeOVR9VN6fAMUg")]
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
        
        /// <summary>
        /// Specifies how the net amount to be paid is related to different purchase orders.
        /// </summary>
        [IsoId("_Ti7gxxrYEeOVR9VN6fAMUg")]
        [DisplayName("Breakdown By Purchase Order")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BrkdwnByPurchsOrdr")]
        #endif
        [IsoXmlTag("BrkdwnByPurchsOrdr")]
        public ValueList<ReportLine7> BreakdownByPurchaseOrder { get; init; } = new ValueList<ReportLine7>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _Ti7gxxrYEeOVR9VN6fAMUg
        
        
        #nullable disable
        
    }
}
