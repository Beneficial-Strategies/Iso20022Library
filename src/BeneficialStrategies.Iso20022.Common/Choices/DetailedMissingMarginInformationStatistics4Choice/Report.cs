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
namespace BeneficialStrategies.Iso20022.Choices.DetailedMissingMarginInformationStatistics4Choice
{
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_rsDiw1owEe23K4GXSpBSeg")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : DetailedMissingMarginInformationStatistics4Choice_
    #else
    public partial class Report : DetailedMissingMarginInformationStatistics4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( System.UInt64 reqNumberOfOutstandingDerivatives,System.UInt64 reqNumberOfOutstandingDerivativesWithNoMarginInformation,System.UInt64 reqNumberOfOutstandingDerivativesWithOutdatedMarginInformation )
        {
            NumberOfOutstandingDerivatives = reqNumberOfOutstandingDerivatives;
            NumberOfOutstandingDerivativesWithNoMarginInformation = reqNumberOfOutstandingDerivativesWithNoMarginInformation;
            NumberOfOutstandingDerivativesWithOutdatedMarginInformation = reqNumberOfOutstandingDerivativesWithOutdatedMarginInformation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Number of outstanding derivatives. 
        /// </summary>
        [IsoId("_rtPOgVowEe23K4GXSpBSeg")]
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
        /// Number of outstanding derivatives with no margin information.
        /// </summary>
        [IsoId("_rtPOg1owEe23K4GXSpBSeg")]
        [DisplayName("Number Of Outstanding Derivatives With No Margin Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NbOfOutsdngDerivsWthNoMrgnInf")]
        #endif
        [IsoXmlTag("NbOfOutsdngDerivsWthNoMrgnInf")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
        #else
        public System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Number of outstanding derivatives with outdated margin information.
        /// </summary>
        [IsoId("_rtPOhVowEe23K4GXSpBSeg")]
        [DisplayName("Number Of Outstanding Derivatives With Outdated Margin Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NbOfOutsdngDerivsWthOutdtdMrgnInf")]
        #endif
        [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdMrgnInf")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
        #else
        public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Details of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
        /// </summary>
        [IsoId("_rtPOh1owEe23K4GXSpBSeg")]
        [DisplayName("Warnings")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Wrnngs")]
        #endif
        [IsoXmlTag("Wrnngs")]
        public ValueList<MissingMarginData2> Warnings { get; init; } = new ValueList<MissingMarginData2>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _rtPOh1owEe23K4GXSpBSeg
        
        
        #nullable disable
        
    }
}
