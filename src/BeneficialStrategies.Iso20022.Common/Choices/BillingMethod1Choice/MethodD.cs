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
    /// Tax values are based on tax calculation method D.
    /// </summary>
    [IsoId("_6P9DtJqlEeGSON8vddiWzQ_1766081075")]
    [DisplayName("Method D")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MethodD : BillingMethod1Choice_
    #else
    public partial class MethodD : BillingMethod1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MethodD instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MethodD( AmountAndDirection34 reqServiceTaxPriceAmount )
        {
            ServiceTaxPriceAmount = reqServiceTaxPriceAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Equivalent amount to the service tax host amount but allows the sender to optionally express the value in the pricing currency.
        /// </summary>
        [IsoId("_6QGNoZqlEeGSON8vddiWzQ_-823441647")]
        [DisplayName("Service Tax Price Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SvcTaxPricAmt")]
        #endif
        [IsoXmlTag("SvcTaxPricAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AmountAndDirection34 ServiceTaxPriceAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AmountAndDirection34 ServiceTaxPriceAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection34 ServiceTaxPriceAmount { get; init; } 
        #else
        public AmountAndDirection34 ServiceTaxPriceAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Provides for the specific tax identification within the same tax region. 
        /// Usage: This element allows for a maximum of three regional taxes on the same service.
        /// </summary>
        [IsoId("_6QGNopqlEeGSON8vddiWzQ_480308590")]
        [DisplayName("Tax Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxId")]
        #endif
        [IsoXmlTag("TaxId")]
        [MinLength(1)]
        [MaxLength(3)]
        public ValueList<BillingServicesTax2> TaxIdentification { get; init; } = new ValueList<BillingServicesTax2>(){};
        
        
        #nullable disable
        
    }
}
