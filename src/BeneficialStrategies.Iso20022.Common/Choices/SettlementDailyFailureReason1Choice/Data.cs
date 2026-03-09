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
namespace BeneficialStrategies.Iso20022.Choices.SettlementDailyFailureReason1Choice
{
    /// <summary>
    /// Aggregated data of settlement instructions.
    /// </summary>
    [IsoId("_UCFuEzOlEeqX8uoQQ3KffQ")]
    [DisplayName("Data")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Data : SettlementDailyFailureReason1Choice_
    #else
    public partial class Data : SettlementDailyFailureReason1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Data instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Data( SettlementTotalData1Choice_ reqFailedSecurities,SettlementTotalData1Choice_ reqFailedCash )
        {
            FailedSecurities = reqFailedSecurities;
            FailedCash = reqFailedCash;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Fails due to lack of securities.
        /// </summary>
        [IsoId("_MRbYsTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Failed Securities")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FaildScties")]
        #endif
        [IsoXmlTag("FaildScties")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementTotalData1Choice_ FailedSecurities { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementTotalData1Choice_ FailedSecurities { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementTotalData1Choice_ FailedSecurities { get; init; } 
        #else
        public SettlementTotalData1Choice_ FailedSecurities { get; set; } 
        #endif
        
        /// <summary>
        /// Fails due to lack of cash.
        /// </summary>
        [IsoId("_MRbYszOmEeqX8uoQQ3KffQ")]
        [DisplayName("Failed Cash")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FaildCsh")]
        #endif
        [IsoXmlTag("FaildCsh")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementTotalData1Choice_ FailedCash { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementTotalData1Choice_ FailedCash { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementTotalData1Choice_ FailedCash { get; init; } 
        #else
        public SettlementTotalData1Choice_ FailedCash { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
