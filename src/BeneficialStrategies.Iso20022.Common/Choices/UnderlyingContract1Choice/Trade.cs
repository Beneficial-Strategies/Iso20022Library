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
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingContract1Choice
{
    /// <summary>
    /// Underlying registered contract is a commercial trade.
    /// </summary>
    [IsoId("_x2Ue89LJEeSdq5yU2aaSNw")]
    [DisplayName("Trade")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Trade : UnderlyingContract1Choice_
    #else
    public partial class Trade : UnderlyingContract1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Trade instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Trade( ActiveCurrencyAndAmount reqAmount,System.DateOnly reqMaturityDate,System.String reqProlongationFlag,System.DateOnly reqStartDate,string reqSettlementCurrency )
        {
            Amount = reqAmount;
            MaturityDate = reqMaturityDate;
            ProlongationFlag = reqProlongationFlag;
            StartDate = reqStartDate;
            SettlementCurrency = reqSettlementCurrency;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contract document referenced from this trade agreement.
        /// </summary>
        [IsoId("_RZltddNDEeSDLevdaFPXHw")]
        [DisplayName("Contract Document Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctDocId")]
        #endif
        [IsoXmlTag("CtrctDocId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
        #else
        public DocumentIdentification22? ContractDocumentIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of the trade contract.
        /// </summary>
        [IsoId("_oHnIENNEEeSDLevdaFPXHw")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount Amount { get; init; } 
        #else
        public ActiveCurrencyAndAmount Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that is specified as the buyer for this trade agreement.
        /// </summary>
        [IsoId("_RZltc9NDEeSDLevdaFPXHw")]
        [DisplayName("Buyer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Buyr")]
        #endif
        [IsoXmlTag("Buyr")]
        public ValueList<TradeParty2> Buyer { get; init; } = new ValueList<TradeParty2>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _RZltc9NDEeSDLevdaFPXHw
        
        /// <summary>
        /// Party that is specified as the seller for this trade agreement.
        /// </summary>
        [IsoId("_RZltdNNDEeSDLevdaFPXHw")]
        [DisplayName("Seller")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sellr")]
        #endif
        [IsoXmlTag("Sellr")]
        public ValueList<TradeParty2> Seller { get; init; } = new ValueList<TradeParty2>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _RZltdNNDEeSDLevdaFPXHw
        
        /// <summary>
        /// Planned final payment date at the time of issuance.
        /// </summary>
        [IsoId("_r21y4NNEEeSDLevdaFPXHw")]
        [DisplayName("Maturity Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MtrtyDt")]
        #endif
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate MaturityDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly MaturityDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly MaturityDate { get; init; } 
        #else
        public System.DateOnly MaturityDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the contract duration is extended or not.
        /// </summary>
        [IsoId("_wrZHANNEEeSDLevdaFPXHw")]
        [DisplayName("Prolongation Flag")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrlngtnFlg")]
        #endif
        [IsoXmlTag("PrlngtnFlg")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator ProlongationFlag { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ProlongationFlag { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ProlongationFlag { get; init; } 
        #else
        public System.String ProlongationFlag { get; set; } 
        #endif
        
        /// <summary>
        /// Start date of the trade contract.
        /// </summary>
        [IsoId("_y6NvANNEEeSDLevdaFPXHw")]
        [DisplayName("Start Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StartDt")]
        #endif
        [IsoXmlTag("StartDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate StartDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly StartDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly StartDate { get; init; } 
        #else
        public System.DateOnly StartDate { get; set; } 
        #endif
        
        /// <summary>
        /// Currency in which the trade is being settled.
        /// </summary>
        [IsoId("_2jC24NNEEeSDLevdaFPXHw")]
        [DisplayName("Settlement Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmCcy")]
        #endif
        [IsoXmlTag("SttlmCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyCode SettlementCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string SettlementCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string SettlementCurrency { get; init; } 
        #else
        public string SettlementCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Provides details on the currency exchange rate and contract.
        /// </summary>
        [IsoId("_wb2E8dONEeSQ_-lmj1tzfw")]
        [DisplayName("Exchange Rate Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XchgRateInf")]
        #endif
        [IsoXmlTag("XchgRateInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExchangeRate1? ExchangeRateInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExchangeRate1? ExchangeRateInformation { get; init; } 
        #else
        public ExchangeRate1? ExchangeRateInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Schedule of the payments defined for the trade contract.
        /// </summary>
        [IsoId("_5ukXsNNEEeSDLevdaFPXHw")]
        [DisplayName("Payment Schedule")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtSchdl")]
        #endif
        [IsoXmlTag("PmtSchdl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestPaymentDateRange1? PaymentSchedule { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestPaymentDateRange1? PaymentSchedule { get; init; } 
        #else
        public InterestPaymentDateRange1? PaymentSchedule { get; set; } 
        #endif
        
        /// <summary>
        /// Schedule of the shipment.
        /// </summary>
        [IsoId("_7q8k0NNEEeSDLevdaFPXHw")]
        [DisplayName("Shipment Schedule")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShipmntSchdl")]
        #endif
        [IsoXmlTag("ShipmntSchdl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
        #else
        public ShipmentSchedule2Choice_? ShipmentSchedule { get; set; } 
        #endif
        
        /// <summary>
        /// Documents provided as attachments to the trade contract.
        /// </summary>
        [IsoId("_HyjhwdNDEeSDLevdaFPXHw")]
        [DisplayName("Attachment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Attchmnt")]
        #endif
        [IsoXmlTag("Attchmnt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DocumentGeneralInformation3? Attachment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentGeneralInformation3? Attachment { get; init; } 
        #else
        public DocumentGeneralInformation3? Attachment { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
