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
namespace BeneficialStrategies.Iso20022.Choices.DefinedAttributes1Choice
{
    /// <summary>
    /// Shares or some other fixed amount of derivative (such an ERIS future or swaption), or a fixed quantity of commodities.
    /// </summary>
    [IsoId("__F7tMOPJEea7_eMQH225xA")]
    [DisplayName("Quantity Defined Attributes")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record QuantityDefinedAttributes : DefinedAttributes1Choice_
    #else
    public partial class QuantityDefinedAttributes : DefinedAttributes1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a QuantityDefinedAttributes instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public QuantityDefinedAttributes( ContractSize1 reqContractSize,PhysicalTransferType4Code reqDeliveryType,GenericIdentification165 reqUnderlyingIdentification,string reqPriceCurrency )
        {
            ContractSize = reqContractSize;
            DeliveryType = reqDeliveryType;
            UnderlyingIdentification = reqUnderlyingIdentification;
            PriceCurrency = reqPriceCurrency;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Quantity of product defined in the contract.
        /// </summary>
        [IsoId("_lvercMhjEeadgvwNGwK05w")]
        [DisplayName("Contract Size")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctSz")]
        #endif
        [IsoXmlTag("CtrctSz")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ContractSize1 ContractSize { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ContractSize1 ContractSize { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractSize1 ContractSize { get; init; } 
        #else
        public ContractSize1 ContractSize { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the contract is cash/physical/optional settled.
        /// </summary>
        [IsoId("_ZPUhEMhkEeadgvwNGwK05w")]
        [DisplayName("Delivery Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DlvryTp")]
        #endif
        [IsoXmlTag("DlvryTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PhysicalTransferType4Code DeliveryType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PhysicalTransferType4Code DeliveryType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PhysicalTransferType4Code DeliveryType { get; init; } 
        #else
        public PhysicalTransferType4Code DeliveryType { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identifier for underlying or deliverable financial product on which final settlement price or equivalent is calculated.
        /// </summary>
        [IsoId("_dlsEYMhkEeadgvwNGwK05w")]
        [DisplayName("Underlying Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygId")]
        #endif
        [IsoXmlTag("UndrlygId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification165 UnderlyingIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification165 UnderlyingIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification165 UnderlyingIdentification { get; init; } 
        #else
        public GenericIdentification165 UnderlyingIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the currency of price of underlying.
        /// </summary>
        [IsoId("_0ce18MhkEeadgvwNGwK05w")]
        [DisplayName("Price Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PricCcy")]
        #endif
        [IsoXmlTag("PricCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyCode PriceCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string PriceCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string PriceCurrency { get; init; } 
        #else
        public string PriceCurrency { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
