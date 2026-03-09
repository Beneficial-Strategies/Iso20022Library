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
namespace BeneficialStrategies.Iso20022.Choices.BillingMethod1Choice
{
    /// <summary>
    /// Tax values are based on tax calculation method A.
    /// </summary>
    [IsoId("_6P9DspqlEeGSON8vddiWzQ_1371622889")]
    [DisplayName("Method A")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MethodA : BillingMethod1Choice_
    #else
    public partial class MethodA : BillingMethod1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MethodA instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MethodA( AmountAndDirection34 reqServiceChargeHostAmount,BillingServicesAmount1 reqServiceTax,BillingServicesAmount2 reqTotalCharge )
        {
            ServiceChargeHostAmount = reqServiceChargeHostAmount;
            ServiceTax = reqServiceTax;
            TotalCharge = reqTotalCharge;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Amount of the original charge expressed in the host currency.
        /// </summary>
        [IsoId("_6PzStZqlEeGSON8vddiWzQ_-378796185")]
        [DisplayName("Service Charge Host Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SvcChrgHstAmt")]
        #endif
        [IsoXmlTag("SvcChrgHstAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AmountAndDirection34 ServiceChargeHostAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AmountAndDirection34 ServiceChargeHostAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection34 ServiceChargeHostAmount { get; init; } 
        #else
        public AmountAndDirection34 ServiceChargeHostAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Provides for the regional taxes on the service. Up to three regional taxes may be defined for the same service.
        /// </summary>
        [IsoId("_6PzStpqlEeGSON8vddiWzQ_996223479")]
        [DisplayName("Service Tax")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SvcTax")]
        #endif
        [IsoXmlTag("SvcTax")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BillingServicesAmount1 ServiceTax { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BillingServicesAmount1 ServiceTax { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BillingServicesAmount1 ServiceTax { get; init; } 
        #else
        public BillingServicesAmount1 ServiceTax { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the total charge for a service (including taxes).
        /// </summary>
        [IsoId("_6PzSt5qlEeGSON8vddiWzQ_451070786")]
        [DisplayName("Total Charge")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TtlChrg")]
        #endif
        [IsoXmlTag("TtlChrg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BillingServicesAmount2 TotalCharge { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BillingServicesAmount2 TotalCharge { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BillingServicesAmount2 TotalCharge { get; init; } 
        #else
        public BillingServicesAmount2 TotalCharge { get; set; } 
        #endif
        
        /// <summary>
        /// Provides for the specific tax identification within the same tax region. 
        /// Usage: This element allows for a maximum of three regional taxes on the same service.
        /// </summary>
        [IsoId("_6P9DsJqlEeGSON8vddiWzQ_-1164327431")]
        [DisplayName("Tax Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxId")]
        #endif
        [IsoXmlTag("TaxId")]
        [MinLength(1)]
        [MaxLength(3)]
        public ValueList<BillingServicesTax1> TaxIdentification { get; init; } = new ValueList<BillingServicesTax1>(){};
        
        
        #nullable disable
        
    }
}
