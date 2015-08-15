﻿// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using CalDavSynchronizer.Implementation.ComWrappers;
using DDay.iCal;
using GenSync.EntityMapping;
using Microsoft.Office.Interop.Outlook;
using Thought.vCards;

namespace CalDavSynchronizer.Implementation.Contacts
{
  public class ContactEntityMapper : IEntityMapper<GenericComObjectWrapper<ContactItem>, vCard>
  {
    public vCard Map1To2 (GenericComObjectWrapper<ContactItem> source, vCard target)
    {
      target.GivenName = source.Inner.FirstName;
      target.FamilyName = source.Inner.LastName;

      return target;
    }

    public GenericComObjectWrapper<ContactItem> Map2To1 (vCard source, GenericComObjectWrapper<ContactItem> target)
    {
      target.Inner.FirstName = source.GivenName;
      target.Inner.LastName = source.FamilyName;

      return target;
    }
  }
}