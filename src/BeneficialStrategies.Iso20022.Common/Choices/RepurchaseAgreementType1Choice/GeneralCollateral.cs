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
namespace BeneficialStrategies.Iso20022.Choices.RepurchaseAgreementType1Choice
{
    /// <summary>
    /// Repurchase agreement where the agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
    /// </summary>
    [IsoId("_EbIM8LbrEeaqL_M7XFD7PQ")]
    [DisplayName("General Collateral")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record GeneralCollateral : RepurchaseAgreementType1Choice_
    #else
    public partial class GeneralCollateral : RepurchaseAgreementType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// List of the identifiers of the securities eligible for a general collateral repurchase agreement.
        /// </summary>
        [IsoId("_OFpSY8huEeadgvwNGwK05w")]
        [DisplayName("Eligible Financial Instrument Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ElgblFinInstrmId")]
        #endif
        [IsoXmlTag("ElgblFinInstrmId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public SimpleValueList<System.String> EligibleFinancialInstrumentIdentification { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _OFpSY8huEeadgvwNGwK05w
        
        
        #nullable disable
        
    }
}
