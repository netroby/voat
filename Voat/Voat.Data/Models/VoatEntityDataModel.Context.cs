﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System.Linq;

    public partial class voatEntities : DbContext
    {
        public class UnintentionalCodeFirstException : Exception { }
        public voatEntities()
        //: base("name=voatEntities")//FIXME
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<BannedDomain> BannedDomains { get; set; }
        public virtual DbSet<BannedUser> BannedUsers { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentRemovalLog> CommentRemovalLogs { get; set; }
        public virtual DbSet<CommentSaveTracker> CommentSaveTrackers { get; set; }
        public virtual DbSet<CommentVoteTracker> CommentVoteTrackers { get; set; }
        public virtual DbSet<DefaultSubverse> DefaultSubverses { get; set; }
        public virtual DbSet<ModeratorInvitation> ModeratorInvitations { get; set; }
        public virtual DbSet<SessionTracker> SessionTrackers { get; set; }
        public virtual DbSet<StickiedSubmission> StickiedSubmissions { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<SubmissionRemovalLog> SubmissionRemovalLogs { get; set; }
        public virtual DbSet<SubmissionSaveTracker> SubmissionSaveTrackers { get; set; }
        public virtual DbSet<SubmissionVoteTracker> SubmissionVoteTrackers { get; set; }
        public virtual DbSet<Subverse> Subverses { get; set; }
        public virtual DbSet<SubverseBan> SubverseBans { get; set; }
        public virtual DbSet<SubverseFlair> SubverseFlairs { get; set; }
        public virtual DbSet<SubverseModerator> SubverseModerators { get; set; }
        public virtual DbSet<UserBadge> UserBadges { get; set; }
        public virtual DbSet<UserPreference> UserPreferences { get; set; }
        public virtual DbSet<ViewStatistic> ViewStatistics { get; set; }
        public virtual DbSet<ApiClient> ApiClients { get; set; }
        public virtual DbSet<ApiLog> ApiLogs { get; set; }
        public virtual DbSet<ApiThrottlePolicy> ApiThrottlePolicies { get; set; }
        public virtual DbSet<EventLog> EventLogs { get; set; }
        public virtual DbSet<ApiCorsPolicy> ApiCorsPolicies { get; set; }
        public virtual DbSet<ApiPermissionPolicy> ApiPermissionPolicies { get; set; }
        public virtual DbSet<UserBlockedUser> UserBlockedUsers { get; set; }
        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<RuleReport> RuleReports { get; set; }
        public virtual DbSet<RuleSet> RuleSets { get; set; }
        public virtual DbSet<UserContribution> UserContributions { get; set; }
        public virtual DbSet<SubverseSet> SubverseSets { get; set; }
        public virtual DbSet<SubverseSetList> SubverseSetLists { get; set; }
        public virtual DbSet<SubverseSetSubscription> SubverseSetSubscriptions { get; set; }
        public virtual DbSet<Featured> Featureds { get; set; }

        public virtual ObjectResult<usp_CommentTree_Result> usp_CommentTree(Nullable<int> submissionID, Nullable<int> depth, Nullable<int> parentID)
        {
			//CORE_PORT: Code not worky
			throw new NotImplementedException("Core Port Problems");
            /*
			var submissionIDParameter = submissionID.HasValue ?
                new ObjectParameter("SubmissionID", submissionID) :
                new ObjectParameter("SubmissionID", typeof(int));

            var depthParameter = depth.HasValue ?
                new ObjectParameter("Depth", depth) :
                new ObjectParameter("Depth", typeof(int));

            var parentIDParameter = parentID.HasValue ?
                new ObjectParameter("ParentID", parentID) :
                new ObjectParameter("ParentID", typeof(int));

            var result = ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_CommentTree_Result>("usp_CommentTree", submissionIDParameter, depthParameter, parentIDParameter);
            return result;
			*/
        }
	}
}
