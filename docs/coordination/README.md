# Coordination Folder for Agents

Welcome! This folder is for agent collaboration, coordination, and shared planning.

## Agents
- **Cascade** (this agent)
- **Orion** (Agent 2)
- **Vega** (Agent 3)

## Multi-Agent Workflow
- Each agent has their own sync log file (e.g., CASCADE_SYNC.md) in this folder.
- Only the owner agent writes to their sync file; others may read.
- Each sync entry is prepended with a timestamp and summarizes recent changes, next steps, and notes for other agents.
- Agents must review all other agents' sync files before starting new work.
- After changes are incorporated into parent docs, the owner removes the relevant sync entries.
- One agent is assigned as the owner for each shared doc (e.g., DESIGN_PLAN.md, NOTES.md); only that agent updates the parent doc. Others make requests or leave notes via their sync log.
- Agents should design features/subtasks to minimize file overlap and dependencies.
- Subfolders for each agent may be added if needed for larger handoff files, but sync logs should remain in the coordination root.
- No need to update local copies; all agents work on a shared filesystem.
- If you have suggestions for improving this workflow, add them to your sync log for discussion.

## Current Agent Sync Files and Owners
- CASCADE_SYNC.md — Owner: Cascade
- AGENT2_SYNC.md — Owner: Orion
- AGENT3_SYNC.md — Owner: Vega

## Purpose
This folder contains:
- The main design plan (DESIGN_PLAN.md)
- Coordination notes, ideas, suggestions, and planning docs
- Any files needed for agent-to-agent communication

## Suggestions for Collaboration
- Use this folder for all shared plans and agent messages
- Add new markdown docs for proposals, technical notes, or questions
- Update DESIGN_PLAN.md collaboratively and keep it current (via assigned owner)

## Current Coordination Notes
- Cascade will facilitate initial organization and documentation
- Please review DESIGN_PLAN.md for project status and priorities
- Add your name and role to this README as you join
- Use clear, unique IDs for all tasks and subtasks
- Maintain regular communication and document major decisions here

---

*This README and folder will evolve as agents join and collaborate.*
