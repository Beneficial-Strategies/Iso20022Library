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
namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice
{
    /// <summary>
    /// Details specific for Interest rate.
    /// </summary>
    [IsoId("_Bv9MQ2kwEeaLAKoEUNsD9g")]
    [DisplayName("Interest Rate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record InterestRate : Derivative2Choice_
    #else
    public partial class InterestRate : Derivative2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a InterestRate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public InterestRate( InterestRateDerivative2Choice_ reqUnderlyingType,FloatingInterestRate8 reqInterestRateReference )
        {
            UnderlyingType = reqUnderlyingType;
            InterestRateReference = reqInterestRateReference;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specific details on the underlying type of the interest rate derivative.
        /// </summary>
        [IsoId("_xSfx8WlIEeaLAKoEUNsD9g")]
        [DisplayName("Underlying Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygTp")]
        #endif
        [IsoXmlTag("UndrlygTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InterestRateDerivative2Choice_ UnderlyingType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InterestRateDerivative2Choice_ UnderlyingType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateDerivative2Choice_ UnderlyingType { get; init; } 
        #else
        public InterestRateDerivative2Choice_ UnderlyingType { get; set; } 
        #endif
        
        /// <summary>
        /// Populated when the underlying type is a bond or a bond future. Details the issuer and maturity date of the bond.
        /// </summary>
        [IsoId("_xSfx82lIEeaLAKoEUNsD9g")]
        [DisplayName("Underlying Bond")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygBd")]
        #endif
        [IsoXmlTag("UndrlygBd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BondDerivative2? UnderlyingBond { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BondDerivative2? UnderlyingBond { get; init; } 
        #else
        public BondDerivative2? UnderlyingBond { get; set; } 
        #endif
        
        /// <summary>
        /// Notional currency of a swaption.
        /// </summary>
        [IsoId("_xSfx9WlIEeaLAKoEUNsD9g")]
        [DisplayName("Swaption Notional Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SwptnNtnlCcy")]
        #endif
        [IsoXmlTag("SwptnNtnlCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyCode? SwaptionNotionalCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? SwaptionNotionalCurrency { get; init; } 
        #else
        public string? SwaptionNotionalCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Maturity date of the underlying swap, populated for swaptions, futures on swaps and forwards on a swap only.
        /// </summary>
        [IsoId("_xSfx92lIEeaLAKoEUNsD9g")]
        [DisplayName("Underlying Swap Maturity Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygSwpMtrtyDt")]
        #endif
        [IsoXmlTag("UndrlygSwpMtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? UnderlyingSwapMaturityDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? UnderlyingSwapMaturityDate { get; init; } 
        #else
        public System.DateOnly? UnderlyingSwapMaturityDate { get; set; } 
        #endif
        
        /// <summary>
        /// Populated to define the inflation index.
        /// </summary>
        [IsoId("_xSfx-WlIEeaLAKoEUNsD9g")]
        [DisplayName("Inflation Index")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InfltnIndx")]
        #endif
        [IsoXmlTag("InfltnIndx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InflationIndex1Choice_? InflationIndex { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InflationIndex1Choice_? InflationIndex { get; init; } 
        #else
        public InflationIndex1Choice_? InflationIndex { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the interest rate against a reference rate and term in number of days, weeks, months or years.
        /// </summary>
        [IsoId("_xSfx-2lIEeaLAKoEUNsD9g")]
        [DisplayName("Interest Rate Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrstRateRef")]
        #endif
        [IsoXmlTag("IntrstRateRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FloatingInterestRate8 InterestRateReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FloatingInterestRate8 InterestRateReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FloatingInterestRate8 InterestRateReference { get; init; } 
        #else
        public FloatingInterestRate8 InterestRateReference { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
