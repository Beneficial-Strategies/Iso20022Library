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
namespace BeneficialStrategies.Iso20022.Choices.DetailedMissingValuationsStatistics4Choice
{
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_x1GY41yGEe24CqbZJK5XxA")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : DetailedMissingValuationsStatistics4Choice_
    #else
    public partial class Report : DetailedMissingValuationsStatistics4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( System.UInt64 reqNumberOfOutstandingDerivatives,System.UInt64 reqNumberOfOutstandingDerivativesWithNoValuation,System.UInt64 reqNumberOfOutstandingDerivativesWithOutdatedValuation )
        {
            NumberOfOutstandingDerivatives = reqNumberOfOutstandingDerivatives;
            NumberOfOutstandingDerivativesWithNoValuation = reqNumberOfOutstandingDerivativesWithNoValuation;
            NumberOfOutstandingDerivativesWithOutdatedValuation = reqNumberOfOutstandingDerivativesWithOutdatedValuation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Number of outstanding derivatives. 
        /// </summary>
        [IsoId("_x2DbIFyGEe24CqbZJK5XxA")]
        [DisplayName("Number Of Outstanding Derivatives")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NbOfOutsdngDerivs")]
        #endif
        [IsoXmlTag("NbOfOutsdngDerivs")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 NumberOfOutstandingDerivatives { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 NumberOfOutstandingDerivatives { get; init; } 
        #else
        public System.UInt64 NumberOfOutstandingDerivatives { get; set; } 
        #endif
        
        /// <summary>
        /// Number of outstanding derivatives for which valuation amount was never reported.
        /// </summary>
        [IsoId("_x2DbIlyGEe24CqbZJK5XxA")]
        [DisplayName("Number Of Outstanding Derivatives With No Valuation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NbOfOutsdngDerivsWthNoValtn")]
        #endif
        [IsoXmlTag("NbOfOutsdngDerivsWthNoValtn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
        #else
        public System.UInt64 NumberOfOutstandingDerivativesWithNoValuation { get; set; } 
        #endif
        
        /// <summary>
        /// Number of outstanding derivatives with outdated valuation.
        /// </summary>
        [IsoId("_x2DbJFyGEe24CqbZJK5XxA")]
        [DisplayName("Number Of Outstanding Derivatives With Outdated Valuation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NbOfOutsdngDerivsWthOutdtdValtn")]
        #endif
        [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdValtn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
        #else
        public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedValuation { get; set; } 
        #endif
        
        /// <summary>
        /// Details of outstanding derivatives for which the valuation was not reported or the valuation reported is more than fourteen calendar days earlier than the date for which the report was generated shall be included in the report of missing valuations at the end of the day.
        /// </summary>
        [IsoId("_x2DbJlyGEe24CqbZJK5XxA")]
        [DisplayName("Warnings")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Wrnngs")]
        #endif
        [IsoXmlTag("Wrnngs")]
        public ValueList<MissingValuationsData2> Warnings { get; init; } = new ValueList<MissingValuationsData2>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _x2DbJlyGEe24CqbZJK5XxA
        
        
        #nullable disable
        
    }
}
