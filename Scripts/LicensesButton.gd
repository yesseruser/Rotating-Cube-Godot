extends Button

func _pressed() -> void:
	(get_node("/root/main/UI/Licenses/AnimationPlayer") as AnimationPlayer).play("Open")
