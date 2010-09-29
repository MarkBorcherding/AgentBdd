require 'rake'
require 'FileUtils'

PLUGIN_DIR = File.join( ENV['PROGRAMFILES'], 'JetBrains', 'ReSharper', 'v5.1', 'Bin', 'Plugins','AgentBdd')
BIN_DIR = File.join('.','AgentBdd','bin','debug','.')


task :default => [:ensure_directory, :compile, :deploy]

task :ensure_directory do
  mkdir PLUGIN_DIR unless File.exist? PLUGIN_DIR
end

task :compile do
  `msbuild`
end

task :deploy do
  cp_r BIN_DIR, PLUGIN_DIR, :remove_destination => true
end
