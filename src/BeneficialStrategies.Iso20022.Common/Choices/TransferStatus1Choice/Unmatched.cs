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
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is unmatched.
    /// </summary>
    [IsoId("_o1CqqhwkEeOIveEnnb_1-A")]
    [DisplayName("Unmatched")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Unmatched : TransferStatus1Choice_
    #else
    public partial class Unmatched : TransferStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Unmatched instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Unmatched( NoReasonCode reqNoSpecifiedReason,TransferUnmatchedReason2Code reqReason,System.String reqExtendedReason,GenericIdentification1 reqDataSourceScheme )
        {
            NoSpecifiedReason = reqNoSpecifiedReason;
            Reason = reqReason;
            ExtendedReason = reqExtendedReason;
            DataSourceScheme = reqDataSourceScheme;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RQNBptp-Ed-ak6NoX_4Aeg_-544756882")]
        [DisplayName("No Specified Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NoSpcfdRsn")]
        #endif
        [IsoXmlTag("NoSpcfdRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoReasonCode NoSpecifiedReason { get; init; } 
        #else
        public NoReasonCode NoSpecifiedReason { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for the unmatched status.
        /// </summary>
        [IsoId("_RQNBp9p-Ed-ak6NoX_4Aeg_-256618190")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TransferUnmatchedReason2Code Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TransferUnmatchedReason2Code Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransferUnmatchedReason2Code Reason { get; init; } 
        #else
        public TransferUnmatchedReason2Code Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for the unmatched status.
        /// </summary>
        [IsoId("_RQWyoNp-Ed-ak6NoX_4Aeg_-256617853")]
        [DisplayName("Extended Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XtndedRsn")]
        #endif
        [IsoXmlTag("XtndedRsn")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExtended350Code ExtendedReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ExtendedReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ExtendedReason { get; init; } 
        #else
        public System.String ExtendedReason { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the reason for the unmatched status.
        /// </summary>
        [IsoId("_RQWyodp-Ed-ak6NoX_4Aeg_-544756821")]
        [DisplayName("Data Source Scheme")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DataSrcSchme")]
        #endif
        [IsoXmlTag("DataSrcSchme")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification1 DataSourceScheme { get; init; } 
        #else
        public GenericIdentification1 DataSourceScheme { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
