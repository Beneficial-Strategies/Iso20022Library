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
namespace BeneficialStrategies.Iso20022.Choices.DisputeNotification2Choice
{
    /// <summary>
    /// Provides the dispute notification details for the segregated independent amount only.
    /// </summary>
    [IsoId("_KkjLoytOEeyOa655cLd-DQ")]
    [DisplayName("Segregated Independent Amount Dispute Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SegregatedIndependentAmountDisputeDetails : DisputeNotification2Choice_
    #else
    public partial class SegregatedIndependentAmountDisputeDetails : DisputeNotification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SegregatedIndependentAmountDisputeDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SegregatedIndependentAmountDisputeDetails( Dispute1 reqDisputeDetails )
        {
            DisputeDetails = reqDisputeDetails;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Details of the disputed instruction.
        /// </summary>
        [IsoId("_da94AStOEeyOa655cLd-DQ")]
        [DisplayName("Dispute Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DsptDtls")]
        #endif
        [IsoXmlTag("DsptDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Dispute1 DisputeDetails { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Dispute1 DisputeDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Dispute1 DisputeDetails { get; init; } 
        #else
        public Dispute1 DisputeDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
        /// </summary>
        [IsoId("_da94AytOEeyOa655cLd-DQ")]
        [DisplayName("Dispute Resolution Type 1 Choice")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DsptRsltnTp1Chc")]
        #endif
        [IsoXmlTag("DsptRsltnTp1Chc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DisputeResolutionType1Choice_? DisputeResolutionType1Choice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DisputeResolutionType1Choice_? DisputeResolutionType1Choice { get; init; } 
        #else
        public DisputeResolutionType1Choice_? DisputeResolutionType1Choice { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
