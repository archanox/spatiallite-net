﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

using SpatialLite.Osm;
using SpatialLite.Osm.Geometries;

namespace Tests.SpatialLite.Osm {
	public class RelationMemberInfoTests {
		#region Constructor(RelationMember)

		[Fact]
		public void Constructor_RelationMember_SetsProperties() {
			RelationMember member = new RelationMember(new Node(1), "test-role");

			RelationMemberInfo target = new RelationMemberInfo(member);

			Assert.Equal(member.Member.ID, target.Reference);
			Assert.Equal(member.MemberType, target.MemberType);
			Assert.Equal(member.Role, target.Role);
		}

		#endregion
	}
}
